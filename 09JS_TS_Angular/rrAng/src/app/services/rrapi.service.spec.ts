import { TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { RRApiService } from './rrapi.service';
import { Restaurant } from '../models/restaurant';

describe('RRApiService', () => {
  let service: RRApiService;
  
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [ HttpClientTestingModule ]
    });
    service = TestBed.inject(RRApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should get all restaurants', async () => {
    let fakeData: Restaurant[] = [
      {
        id: 1,
        name: 'Salt and Straw',
        streetAddress: '123 test ave',
        city: 'test',
        state: 'TS',
        reviews: []
      },
      {
        id: 2,
        name: 'Another Test Restaurant',
        streetAddress: '123 test ave',
        city: 'test',
        state: 'TS',
        reviews: []
      },
    ];
    
    spyOn(service, 'getAllRestaurant').and.returnValue(Promise.resolve(fakeData))

    await service.getAllRestaurant().then((res) => {
      //Verify that the response is what we want
      expect(service.getAllRestaurant).toHaveBeenCalled();
      expect(service.getAllRestaurant).toHaveBeenCalledTimes(1);
      expect(res).toBeTruthy();
      expect(res.length).toEqual(2);
    });
  });

  it('should create restaurants', async () =>
  {
    let fakeInput: Restaurant = {
      id: 1,
      name: 'Salt and Straw',
      streetAddress: '123 test ave',
      city: 'test',
      state: 'TS',
      reviews: []
    };

    spyOn(service, 'createNewRestaurant').and.returnValue(Promise.resolve(fakeInput));

    await service.createNewRestaurant(fakeInput).then((res) => {
      expect(service.createNewRestaurant).toHaveBeenCalledTimes(1)
      expect(service.createNewRestaurant).toHaveBeenCalledWith(fakeInput)

      expect(res).toBeTruthy();
      expect((res as Restaurant).id).toEqual(1);
    })
  })
});
