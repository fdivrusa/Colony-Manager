export class RegistrationRequest {
  title: string;
  firstName: string;
  lastName: string;
  email: string;
  password: string;
  confirmPassord: string;
  acceptTerms: boolean;

  constructor() {
    this.title = '';
    this.firstName = '';
    this.lastName = '';
    this.email = '';
    this.password = '';
    this.confirmPassord = '';
    this.acceptTerms = true;
  }
}
