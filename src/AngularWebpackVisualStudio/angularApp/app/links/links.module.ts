import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { LinksComponent } from './components/links.component';
import { LinksRoutes } from './links.routes';

@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        LinksRoutes
    ],

    declarations: [
        LinksComponent
    ],

    exports: [
        LinksComponent
    ]
})

export class LinksModule { }
