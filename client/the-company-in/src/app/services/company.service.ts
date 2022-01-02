import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CompanyInfo } from '../models/CompanyInfo';
import { CompanyMetadata } from '../models/CompanyMetadata';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root',
})
export class CompanyService {
  private readonly controllerName = 'Company';

  constructor(private httpService: HttpService) {}

  companies: CompanyMetadata[] = [];

  getMetadata(companyDomain: string): Observable<CompanyMetadata> {
    return this.httpService.get<CompanyMetadata>(
      `${this.controllerName}/metadata`,
      {
        companyDomain,
      }
    );
  }

  getInfo(id: string): Observable<CompanyInfo> {
    return this.httpService.get<CompanyInfo>(`${this.controllerName}/info`, {
      id,
    });
  }
}
