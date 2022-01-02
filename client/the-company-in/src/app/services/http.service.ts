import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class HttpService {
  constructor(private http: HttpClient) {}

  get<T>(action: string, params?: any): Observable<T> {
    return this.http.get<T>(`${environment.apiUrl}/${action}`, { params });
  }

  delete(action: string, id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${environment.apiUrl}/${action}/${id}`);
  }

  post<T>(action: string, data?: T) {
    return this.http.post<T>(`${environment.apiUrl}/${action}`, data ?? {});
  }

  patch<T>(action: string, data?: T) {
    return this.http.patch(`${environment.apiUrl}/${action}`, data ?? {});
  }
}
