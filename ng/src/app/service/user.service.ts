import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { AppConfig } from '../config/config';
import { Helpers } from '../helpers/helpers';
import { User } from '../models/user'
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({providedIn: })
export class UserService extends BaseService{
    constructor(private http: HttpClient, private config: AppConfig, helper: Helpers) { 
        super(helper);
    }
    getUsers(): Observable<User[]> {
        return this.http.get(this.pathAPI + 'user', super.header()).pipe(
            catchError(super.handleError)
        )
    }
    
}