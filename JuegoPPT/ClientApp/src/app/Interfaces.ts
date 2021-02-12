export interface Jugador1 {
  RowidJugador1: number,
  NombreJugador1:string
}

export interface Ronda {
  CodigoRonda: string,
  CodigoJugador1: string,
  CodigoJugador2: string,
  MovimientoJugador1: number,
  MovimientoJugador2: number,
  NumeroRonda: number
}

export interface Respuesta {
  Succes: number,
  Data: any,
  Message:string
}
