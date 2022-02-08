import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { RestaurantListComponent } from './restaurant-list.component';
import { RRApiService } from '../services/rrapi.service';
import { Restaurant } from '../models/restaurant';

describe('RestaurantListComponent', () => {
  let component: RestaurantListComponent;
  let fixture: ComponentFixture<RestaurantListComponent>;
  let compiled: HTMLElement;
  let service: RRApiService;
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RestaurantListComponent ],
      imports: [ HttpClientTestingModule ]
    })
    .compileComponents();

    service = TestBed.inject(RRApiService)
  });

  beforeEach(() => {
    spyOn(service, 'getAllRestaurant').and.returnValue(Promise.resolve(fakeData));
    fixture = TestBed.createComponent(RestaurantListComponent);
    component = fixture.componentInstance;
    compiled = fixture.nativeElement;
    fixture.detectChanges();
  });

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

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should call the rrApiService', async () => {

    await fixture.whenStable().then(() => 
    {
      expect(service.getAllRestaurant).toHaveBeenCalled();
      expect(service.getAllRestaurant).toHaveBeenCalledTimes(1);
      expect(component.allResto.length).toEqual(2);
    })
  })

  it('should have restaurant table', async () => {
    await fixture.whenStable().then(() => 
    {
      fixture.detectChanges();
      expect(compiled.querySelector('#restaurant-table')).toBeTruthy();
    })
  });

  it('should display no resto tag if no resto', () => {
    expect(compiled.querySelector('#no-resto')).toBeTruthy();
  })
});
