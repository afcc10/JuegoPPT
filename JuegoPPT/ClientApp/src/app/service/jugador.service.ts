import { HttpClient,HttpHeaders } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Respuesta } from '../Interfaces';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Autorization':'my-auth-token'
  })
}

@Injectable({
  providedIn: 'root'
})

export class JugadorService {
  baseUrl: string;

  constructor(protected http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public Add(NombreJugador1) {
    this.http.post<Respuesta>(this.baseUrl + 'api/Jugador/add',
        { 'NombreJugador1': NombreJugador1 }, httpOptions).subscribe(result => {
          console.log(result);  
        },
          error => console.error
      ) 
  }
}


