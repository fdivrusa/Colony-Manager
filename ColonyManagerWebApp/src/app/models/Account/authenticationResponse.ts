export interface AuthenticationResponse {
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
}
