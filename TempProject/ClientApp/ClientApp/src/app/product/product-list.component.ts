import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html'
})
export class ProductListComponent {
  public products: Product[];

  constructor(http: HttpClient, @Inject('https://localhost:44309/api/product/list') baseUrl: string) {
    http.get<Product[]>(baseUrl + 'product').subscribe(result => {
      this.products = result;
      localStorage.setItem("product", JSON.parse(this.products));
    }, error => console.error(error));
  }
}

interface Product {
  id: number;
  name: string;
  jurisdiction: number;
}
