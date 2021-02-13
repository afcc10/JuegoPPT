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

  public Add(CodigoRonda, CodigoJugador1, CodigoJugador2, MovimientoJugador1,MovimientoJugador2,NumeroRonda) {
    this.http.post<Respuesta>(this.baseUrl + 'api/Ronda/add',
      { 'CodigoRonda': CodigoRonda, 'CodigoJugador1': CodigoJugador1,
        'CodigoJugador2': CodigoJugador2, 'MovimientoJugador1': MovimientoJugador1,
      'MovimientoJugador2':MovimientoJugador2,'NumeroRonda':NumeroRonda }, httpOptions).subscribe(result => {
          console.log(result);
        },
          error => console.error
      )
  }
}
