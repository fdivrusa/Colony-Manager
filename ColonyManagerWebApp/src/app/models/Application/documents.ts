export enum DocumentsEnum {
  BookingConfirmation = 'BookingConfirmation',
  SalesOrderConfirmation = 'SalesOrderConfirmation',
  SalesOrderCancellation = 'SalesOrderCancellation',
}

export enum NotificationType {
  Information = 'INFORMATION',
  Warning = 'WARNING',
  Error = 'ERROR',
  Critical = 'CRITICAL',
}

export class Notification {
  title: string;
  type: NotificationType;
  message: string;

  constructor() {
    this.title = '';
    this.type = NotificationType.Information;
    this.message = '';
  }
}
