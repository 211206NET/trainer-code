import { TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { RRApiService } from './rrapi.service';

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
});
