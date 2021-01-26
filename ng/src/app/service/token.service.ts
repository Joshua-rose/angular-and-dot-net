import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from '../config/config';
import { Helpers } from '../helpers/helpers';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { BaseService } from './base.service';

@Injectable()
export class TokenService extends BaseService {
    private pathAPI = this.config.setting['PathAPI'];
    public errorMessage: string;
    constructor(private http: HttpClient, private config: AppConfig, helper: Helpers) { 
        super(helper);
    }
    auth(data:any):any {
        let body = JSON.stringify(data);
        return this.getToken(body);
    }
    private getToken (body: any): Observable<any> {
        return this.http.post<any>(this.pathAPI + 'token', body, super.header()).pipe(
            catchError(super.handleError)
        )
    }
    
}