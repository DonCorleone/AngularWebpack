import { Injectable } from '@angular/core';

@Injectable()
export class Configuration {
    public Server = 'http://localhost:5000/';
    public ApiUrl = 'api/notes';
    public ServerWithApiUrl = this.Server + this.ApiUrl;
}
