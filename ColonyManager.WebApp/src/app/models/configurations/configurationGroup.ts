export class ConfigurationGroup {
  id: number;
  code: string;
  relatedSubject: string;
  description: string;
  comment: string;
  lastUpdatedDate: Date;
  lastUpdatedUserName: string;

  constructor() {
    this.id = 0;
    this.code = '';
    this.relatedSubject = '';
    this.description = '';
    this.comment = '';
    this.lastUpdatedDate = new Date();
    this.lastUpdatedUserName = '';
  }
}
