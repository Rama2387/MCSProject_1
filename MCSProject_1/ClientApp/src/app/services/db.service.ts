import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from 'oidc-client';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DbService {

  private apiUrl$: string = environment.apiUrl;

  constructor(private _http: HttpClient) { }

  getAllSunClaimEntityRef(): Observable<any> {
    return this._http.get<any>(`${this.apiUrl$}/SunClaimEntityRefs`)
  }
  getSunClaimEntityRefById(claimId: number): Observable<any> {
    return this._http.get<any>(`${this.apiUrl$}/SunClaimEntityRefs/GetClaimById/${claimId}`)
  }

  getSunClaimHeaderById(claimId: number): Observable<any> {
    return this._http.get<any>(`${this.apiUrl$}/SunClaimHeaderData/GetClaimHeaderById/${claimId}`)
  }
}
