import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CompanyDetailsComponent } from './components/company-details/company-details.component';
import { CompanySearchComponent } from './components/company-search/company-search.component';

const routes: Routes = [
  { path: 'company-search', component: CompanySearchComponent },
  { path: 'company-details/:id', component: CompanyDetailsComponent },
  { path: '', redirectTo: '/company-search', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
