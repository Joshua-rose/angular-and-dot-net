import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable()
export class Helpers {
    private authenticationChanged = new Subject<boolean>();

    constructor() { }
    private tokenDefined(): boolean {
        const token = window.localStorage['token']
        return (!(
            token === undefined ||
            token === null ||
            token === 'undefined' ||
            token === 'null' ||
            token === ''

        ))
    }
    public isAuthenticated(): boolean {
        return this.tokenDefined()
    }
    public isAuthenticationChanged(): any {
        return this.authenticationChanged.asObservable();
    }
    public getToken():any{
        const token = window.localStorage['token']
        if (!this.tokenDefined()) {return ''}
        let obj = JSON.parse(token);
        return obj.token;
    }
    public setToken(data:any){
        this.setStorageToken(JSON.stringify(data));
    }
    public failToken() {
      this.setStorageToken(undefined);  
    }
    public logout() {
      this.setStorageToken(undefined);  
    }
    private setStorageToken(value:any){
        window.localStorage['token'] = value;
        this.authenticationChanged.next(this.isAuthenticated())
    }
}