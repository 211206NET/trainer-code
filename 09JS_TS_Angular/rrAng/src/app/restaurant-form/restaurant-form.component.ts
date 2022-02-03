import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Restaurant } from '../models/restaurant';

@Component({
  selector: 'restaurant-form',
  templateUrl: './restaurant-form.component.html',
  styleUrls: ['./restaurant-form.component.css']
})
export class RestaurantFormComponent implements OnInit {
  restaurant: Restaurant = {
    name: 'applebees',
    city: '',
    streetAddress: '',
    state: '',
    id: 0,
    reviews: []
  };
  constructor() { }

  processForm(newRestoForm: NgForm) {
    console.log('form has been submitted', newRestoForm, this.restaurant);

  }

  ngOnInit(): void {
  }

}
