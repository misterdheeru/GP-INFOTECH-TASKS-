import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { DataBindingExamplesComponent } from './components/data-binding-examples/data-binding-examples.component';
import { ComponentCommunicationParrentComponent } from './components/component-communication-parrent/component-communication-parrent.component';

export const routes: Routes = [
    {path:"",component:HomeComponent},
    {path:"app-data-binding-examples",component:DataBindingExamplesComponent},
    {path:"gp-component-communication-parrent",component:ComponentCommunicationParrentComponent},
];
