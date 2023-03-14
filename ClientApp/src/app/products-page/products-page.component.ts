import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-products-page',
  templateUrl: './products-page.component.html',
  styleUrls: ['./products-page.component.css']
})
export class ProductsPageComponent implements OnInit {

  Products: Product[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Product[]>(baseUrl + 'Products').subscribe(result => { this.Products = result; }, error => console.error(error));
  }


ngOnInit(): void{
}

}

interface Product {
  productId: number;

  filename: string;

  name: string;

  price: number;

  description: string;

  
}