import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  output,
  ChangeDetectorRef,
} from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { AppComponentBase } from '@shared/app-component-base';
import {
  ProductServiceProxy,
  ProductDto,
  PermissionDto,
  CreateProductDto,
  PermissionDtoListResultDto
} from '@shared/service-proxies/service-proxies';
import { forEach as _forEach, map as _map } from 'lodash-es';

@Component({
  templateUrl: 'create-product-dialog.component.html'
})
export class CreateProductDialogComponent extends AppComponentBase
  implements OnInit {
  saving = false;
  product = new ProductDto();
  permissions: PermissionDto[] = [];
  checkedPermissionsMap: { [key: string]: boolean } = {};
  defaultPermissionCheckedStatus = true;

  onSave = output<EventEmitter<any>>()

  constructor(
    injector: Injector,
    private _productService: ProductServiceProxy,
    public bsModalRef: BsModalRef,
    private cd: ChangeDetectorRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
    // this._productService
    //   .getAllPermissions()
    //   .subscribe((result: PermissionDtoListResultDto) => {
    //     this.permissions = result.items;
    //     // this.setInitialPermissionsStatus();
    //     this.cd.detectChanges();
    //   });
  }

  // setInitialPermissionsStatus(): void {
  //   _map(this.permissions, (item) => {
  //     this.checkedPermissionsMap[item.name] = this.isPermissionChecked(
  //       item.name
  //     );
  //   });
  // }

  isPermissionChecked(permissionName: string): boolean {
    // just return default permission checked status
    // it's better to use a setting
    return this.defaultPermissionCheckedStatus;
  }

  // onPermissionChange(permission: PermissionDto, $event) {
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

    const product = new CreateProductDto();
    product.init(this.product);
    // product.grantedPermissions = this.getCheckedPermissions();  

    this._productService
      .create(product)
      .subscribe(
        () => {
          this.notify.info(this.l('SavedSuccessfully'));
          this.bsModalRef.hide();
          this.onSave.emit(null);
        },
        () => {
          this.saving = false;
          this.cd.detectChanges();
        }
      );
  }
}
