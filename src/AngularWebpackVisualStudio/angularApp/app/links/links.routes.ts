import { RouterModule, Routes } from '@angular/router';

import { LinksComponent } from './components/links.component';

const routes: Routes = [
    { path: 'links', component: LinksComponent }
];

export const LinksRoutes = RouterModule.forChild(routes);
