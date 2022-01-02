import { Component, OnInit } from '@angular/core';
import { CompanyMetadata } from 'src/app/models/CompanyMetadata';
import { CompanyService } from 'src/app/services/company.service';

@Component({
  selector: 'app-company-search',
  templateUrl: './company-search.component.html',
  styleUrls: ['./company-search.component.scss'],
})
export class CompanySearchComponent implements OnInit {
  constructor(public companyService: CompanyService) {}

  companyDomain: string;
  // companies: CompanyMetadata[] = [];
  ngOnInit(): void {}

  submit() {
    this.companyService.getMetadata(this.companyDomain).subscribe((x) => {
      this.companyService.companies.push(x);
      this.companyDomain = '';
    });
  }

  reset() {
    this.companyService.companies = [];
  }
}
