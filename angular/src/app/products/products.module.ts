import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ProductsRoutingModule } from './products-routing.module';
import { ProductsComponent } from './products.component';
import { CreateProductDialogComponent } from './create-product/create-product-dialog.component';
import { EditProductDialogComponent } from './edit-product/edit-product-dialog.component';

@NgModule({
    declarations: [ProductsComponent, CreateProductDialogComponent, EditProductDialogComponent ],
    imports: [SharedModule, ProductsRoutingModule],
})
export class ProductsModule {}
