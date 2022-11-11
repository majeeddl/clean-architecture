import { Controller, Get } from '@nestjs/common';
import { AppUseCases } from 'src/use-cases/app/app.use-case';

@Controller()
export class AppController {
  constructor(private readonly appUseCases: AppUseCases) {}

  @Get()
  getHello(): string {
    return this.appUseCases.getHello();
  }
}
