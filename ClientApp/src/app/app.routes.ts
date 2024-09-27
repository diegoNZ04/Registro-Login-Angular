import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';

export const routes: Routes = [
  {path: 'home-component', component: HomeComponent},
  {path: 'login-component', component: LoginComponent},
  {path: 'register-component', component: RegisterComponent}
];


