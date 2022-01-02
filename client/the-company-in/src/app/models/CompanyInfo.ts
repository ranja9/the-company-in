import { Category } from './Category';
import { Metrics } from './Metrics';

export interface CompanyInfo {
  id: string;
  name: string;
  legalName: string;
  domain: string;
  category: Category;
  description: string;
  foundedYear: number;
  location: string;
  timeZone: string;
  utcOffset: number;
  logo: string;
  emailProvider: boolean;
  type: string;
  ticker: string;
  phone: string;
  metrics: Metrics;
  indexedAt: Date;
  tech: string[];
  techCategories: string[];
}
