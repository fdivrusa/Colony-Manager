export class User {
  id: number;
  title: string;
  email: string;
  firstName: string;
  lastName: string;
  role: string;
  createdDate: Date;
  updatedDate: Date;
  isVerified: boolean;
  jwtToken: string;

  constructor() {
    this.id = 0;
    this.title = '';
    this.email = '';
    this.firstName = '';
    this.lastName = '';
    this.role = '';
    this.createdDate = new Date();
    this.updatedDate = new Date();
    this.isVerified = false;
    this.jwtToken = '';
  }
}
