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

  public Add(CodigoJugador1, NombreJugador1, CodigoJugador2, NombreJugador2) {
    this.http.post<Respuesta>(this.baseUrl + 'api/Jugador/add',
      { 'CodigoJugador1': CodigoJugador1, 'NombreJugador1': NombreJugador1, 'CodigoJugador2': CodigoJugador2, 'NombreJugador2': NombreJugador2 }, httpOptions).subscribe(result => {
          console.log(result);  
        },
          error => console.error
      ) 
  }
}



