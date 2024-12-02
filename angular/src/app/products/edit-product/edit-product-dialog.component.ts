import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  Output,
  ChangeDetectorRef,
} from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { forEach as _forEach, includes as _includes, map as _map } from 'lodash-es';
import { AppComponentBase } from '@shared/app-component-base';
import {
  ProductServiceProxy,
  GetProductForEditOutput,
  ProductDto,
  PermissionDto,
  ProductEditDto,
  FlatPermissionDto
} from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: 'edit-product-dialog.component.html'
})
export class EditProductDialogComponent extends AppComponentBase
  implements OnInit {
  saving = false;
  id: number;
  product = new ProductEditDto();

  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    private _productService: ProductServiceProxy,
    public bsModalRef: BsModalRef,
    private cd: ChangeDetectorRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this._productService.get(this.id).subscribe((result: ProductDto) => {
      this.product = result;
      this.cd.detectChanges();
    });
  }

  // setInitialPermissionsStatus(): void {
  //   _map(this.permissions, (item) => {
  //     this.checkedPermissionsMap[item.name] = this.isPermissionChecked(
  //       item.name
  //     );
  //   });
  // }

  // isPermissionChecked(permissionName: string): boolean {
  //   return _includes(this.grantedPermissionNames, permissionName);
  // }

  // onPermissionChange(permission: FlatPermissionDto, $event) {
  //   this.checkedPermissionsMap[permission.name] = $event.target.checked;
  // }

  // getCheckedPermissions(): string[] {
  //   const permissions: string[] = [];
  //   _forEach(this.checkedPermissionsMap, function (value, key) {
  //     if (value) {
  //       permissions.push(key);
  //     }
  //   });
  //   return permissions;
  // }

  save(): void {
    this.saving = true;

    const product = new ProductDto();
    product.init(this.product);
    // product.grantedPermissions = this.getCheckedPermissions();

    this._productService.update(product).subscribe(
      () => {
        this.notify.info(this.l('Saved successfully'));
        this.bsModalRef.hide();
        this.onSave.emit();
      },
      () => {
        this.saving = false;
      }
    );
  }
}
