import { Injectable } from '@angular/core';
import { Observable } from '../../node_modules/rxjs';
import { HttpClient } from '../../node_modules/@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TestService {

constructor(private http: HttpClient) {

 }

  getValues(): Observable<any>{
    return this.http.get('http://localhost:5000/api/values');

  }
}
