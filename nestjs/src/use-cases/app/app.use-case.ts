import { Injectable } from '@nestjs/common';

@Injectable()
export class AppUseCases {
  getHello(): string {
    return 'Hello World!';
  }
}
