import { Component, Injector, ChangeDetectorRef } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  ProductServiceProxy,
  ProductDto,
  ProductDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreateProductDialogComponent } from './create-product/create-product-dialog.component';
import { EditProductDialogComponent } from './edit-product/edit-product-dialog.component';

class PagedProductsRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  templateUrl: './products.component.html',
  animations: [appModuleAnimation()]
})
export class ProductsComponent extends PagedListingComponentBase<ProductDto> {
  products: ProductDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _productsService: ProductServiceProxy,
    private _modalService: BsModalService,
    cd: ChangeDetectorRef
  ) {
    super(injector, cd);
  }

  list(
    request: PagedProductsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._productsService
      .getAll(request.keyword, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ProductDtoPagedResultDto) => {
        this.products = result.items;
        this.showPaging(result, pageNumber);
        this.cd.detectChanges();
      });
  }

  delete(product: ProductDto): void {
    abp.message.confirm(
      this.l('ProductDeleteWarningMessage', product.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._productsService
            .delete(product.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  createProduct(): void {
    this.showCreateOrEditProductDialog();
  }

  editProduct(product: ProductDto): void {
    this.showCreateOrEditProductDialog(product.id);
  }

  showCreateOrEditProductDialog(id?: number): void {
    let createOrEditProductDialog: BsModalRef;
    if (!id) {
      createOrEditProductDialog = this._modalService.show(
        CreateProductDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    }
    else {
      createOrEditProductDialog = this._modalService.show(
        EditProductDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditProductDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}