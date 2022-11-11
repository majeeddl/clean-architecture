import { Module } from '@nestjs/common';
import { ConfigModule, ConfigService } from '@nestjs/config';
import { ThrottlerModule } from '@nestjs/throttler';

import configuration from './configuration/configuration';
import { AppController } from './adapters/controllers/app.controller';
import { UserUseCaseModule } from './use-cases/user/user.use-case.module';
import { AppUseCases } from './use-cases/app/app.use-case';
import { GraphQLModule } from '@nestjs/graphql';
import { ApolloDriver, ApolloDriverConfig } from '@nestjs/apollo';

@Module({
  imports: [
    ThrottlerModule.forRoot({
      ttl: 60,
      limit: 10,
    }),
    ConfigModule.forRoot({
      load: [configuration],
    }),
    // GraphQLModule.forRoot<ApolloDriverConfig>({
    //   driver: ApolloDriver,
    //   installSubscriptionHandlers: true,
    //   autoSchemaFile: true,
    //   // autoSchemaFile: join(process.cwd(), "src/schema.gql"),
    //   sortSchema: true,
    // }),
    UserUseCaseModule,
  ],
  controllers: [AppController],
  providers: [AppUseCases],
})
export class AppModule {}
