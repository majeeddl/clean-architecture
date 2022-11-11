import { Injectable } from "@nestjs/common";


@Injectable()
export class  UserUseCases{
    constructor(private readonly dataServices){

    }

    async findUsers(){
        return []
    }
}