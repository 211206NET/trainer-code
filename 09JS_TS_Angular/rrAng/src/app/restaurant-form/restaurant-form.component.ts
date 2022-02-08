import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Restaurant } from '../models/restaurant';
import { RRApiService } from '../services/rrapi.service';

@Component({
  selector: 'restaurant-form',
  templateUrl: './restaurant-form.component.html',
  styleUrls: ['./restaurant-form.component.css']
})
export class RestaurantFormComponent implements OnInit {

  constructor(private rrApi: RRApiService) { }

  restaurant: Restaurant = {
    name: '',
    city: '',
    streetAddress: '',
    state: '',
    id: 0,
    reviews: []
  };

  displayFormSubmitError: boolean = false;

  placeholders = {
    name: 'name of the restaurant'
  }

  processForm(newRestoForm: NgForm) {
    console.log('form has been submitted', newRestoForm, this.restaurant);
    if(newRestoForm.form.status === 'VALID')
    {
      //now we can go ahead and send that post request
      this.rrApi.createNewRestaurant(this.restaurant).then((res) =>
      {
        console.log(res);
      }, (err: any) => console.log(err))
    }
    else
    {
      //This is a good place to show some kind of message to let users know, hey your form is wrong
      this.displayFormSubmitError = true;
    }
  }

  ngOnInit(): void {
  }

}
