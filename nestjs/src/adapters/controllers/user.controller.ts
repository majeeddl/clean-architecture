import { Controller, Get } from "@nestjs/common";
import { UserUseCases } from "src/use-cases/user/user.use-case";


@Controller()
export class UserController{
    constructor(private readonly userUseCase:UserUseCases){}


    @Get()
    async getUsers(){
        return this.userUseCase.findUsers()
    }
}