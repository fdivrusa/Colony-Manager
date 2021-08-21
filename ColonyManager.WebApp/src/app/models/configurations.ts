export class ConfigurationGroup {
  id: number;
  code: string;
  relatedSubject: string;
  description: string;
  comment: string;
  configGenericItems!: ConfigurationItem[];
  lastUpdatedDate: Date;
  lastUpdatedUserName: string;
  isDeleted: boolean;

  constructor() {
    this.id = 0;
    this.code = '';
    this.relatedSubject = '';
    this.description = '';
    this.comment = '';
    this.lastUpdatedDate = new Date();
    this.lastUpdatedUserName = '';
    this.isDeleted = false;
  }
}

export class ConfigurationItem {
  id: number;
  groupId: number;
  description: string;
  comment: string;
  lastUpdatedDate: Date;
  lastUpdatedUserName: string;
  isDeleted: boolean;

  constructor() {
    this.id = 0;
    this.groupId = 0;
    this.description = '';
    this.comment = '';
    this.lastUpdatedDate = new Date();
    this.lastUpdatedUserName = '';
    this.isDeleted = false;
  }
}
