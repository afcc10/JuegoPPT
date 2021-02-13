import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { RondaService } from "../service/ronda.service";

@Component({
  selector: 'app-ronda-jugador2',
  templateUrl: './ronda-jugador2.component.html',
  styleUrls: ['./ronda-jugador2.component.css']
})
export class RondaJugador2Component implements OnInit {

  CodigoRonda:string;
  CodigoJugador2: string;
  NombreJugador2: string;
  NumeroRonda: number = 0;
  MovimientoJugador2:number;

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string,
  protected RondaService: RondaService) {
    this.obtener_localstorage();
    //this.llenar_locarstorage();
  }

  ngOnInit() {
  }

  obtener_localstorage() {
    this.NombreJugador2 = localStorage.getItem("NombreJugador2");
    this.CodigoJugador2 = localStorage.getItem("CodigoJugador2");
    this.NumeroRonda = Number(localStorage.getItem("NumeroRonda"));
    this.CodigoRonda = localStorage.getItem("CodigoRonda");
  }

  llenar_locarstorage(){
    //localStorage.setItem("NumeroRonda", this.NumeroRonda.toString());
  }

  public Add() {
    this.RondaService.Add(this.CodigoRonda, "",
      this.CodigoJugador2, 0,this.MovimientoJugador2, this.NumeroRonda);
  }

  public Piedra(){
    this.MovimientoJugador2 = 1;
  }

  public Papel(){
    this.MovimientoJugador2 = 2;
  }

  public Tijera(){
    this.MovimientoJugador2 = 3;
  }

}
