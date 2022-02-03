import { Component, OnInit } from '@angular/core';
import { Restaurant } from '../models/restaurant';
import { RRApiService } from '../services/rrapi.service';

@Component({
  selector: 'restaurant-list',
  templateUrl: './restaurant-list.component.html',
  styleUrls: ['./restaurant-list.component.css']
})
export class RestaurantListComponent implements OnInit {

  constructor(private apiService: RRApiService) { }

  allResto: Restaurant[] = [];

  ngOnInit(): void {
    this.apiService.getAllRestaurant().then((restoArray) => 
    {
      this.allResto = restoArray;
    })
  }

}