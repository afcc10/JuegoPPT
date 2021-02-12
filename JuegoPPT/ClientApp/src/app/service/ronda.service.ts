import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Respuesta } from '../Interfaces';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Autorization': 'my-auth-token'
  })
}

@Injectable({
  providedIn: 'root'
})

export class RondaService {
  baseUrl: string;

  constructor(protected http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }
}
