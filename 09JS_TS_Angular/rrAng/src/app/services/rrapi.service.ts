import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';
import { Restaurant } from '../models/restaurant';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RRApiService {

  constructor(private http: HttpClient) {}

  rootURL = environment.rrApiRootUrl;

  getAllRestaurant(): Promise<Restaurant[]>
  {
    return firstValueFrom(this.http.get<Restaurant[]>(this.rootURL + "/Restaurant"))
  }

  createNewRestaurant(resto: Restaurant)
  {
    //There is also lastValueFrom() that works the same as the deprecated toPromise()
    return firstValueFrom(this.http.post(this.rootURL + "/Restaurant", resto))
  }
}
