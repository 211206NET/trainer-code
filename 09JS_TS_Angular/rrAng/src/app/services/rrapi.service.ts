import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';
import { Restaurant } from '../models/restaurant';

@Injectable({
  providedIn: 'root'
})
export class RRApiService {

  constructor(private http: HttpClient) {}

  getAllRestaurant(): Promise<Restaurant[]>
  {
    return firstValueFrom(this.http.get<Restaurant[]>("http://rrwebapi-prod.us-west-2.elasticbeanstalk.com/api/Restaurant"))
  }
}
