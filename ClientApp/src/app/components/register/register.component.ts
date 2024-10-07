import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators, ReactiveFormsModule, FormsModule } from '@angular/forms';
import { User } from '../../Models/User';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [
    FormsModule,
    ReactiveFormsModule,
    CommonModule
  ],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  // forms Validation
  formRegister = new FormGroup ({
  email: new FormControl('', [Validators.required, Validators.minLength(8)]),
  emailRepeat: new FormControl('', [Validators.required, Validators.minLength(8)]),
  password: new FormControl('', [Validators.required, Validators.minLength(8), Validators.maxLength(12)]),
  passwordRepeat: new FormControl('', [Validators.required, Validators.minLength(8), Validators.maxLength(12)]),
  address: new FormControl('', [Validators.required, Validators.minLength(8), Validators.maxLength(80)]),
  complement: new FormControl(''),
  city: new FormControl('', [Validators.required]),
 });


 // User Vetor
 userVetor: User[] = [];

 // Register Function
 register(){
  this.userVetor.push(this.formRegister.value as User);
  this.formRegister.reset();
 }


}
