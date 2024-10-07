import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { HomeComponent } from './components/home/home.component';

export const routes: Routes = [
  {path: '', redirectTo: '/home-component', pathMatch: 'full'},
  {path: 'home-component', component: HomeComponent},
  {path: 'login-component', component: LoginComponent},
  {path: 'register-component', component: RegisterComponent}
];


