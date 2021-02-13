import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { RondaService } from "../service/ronda.service";

@Component({
  selector: 'app-rondas',
  templateUrl: './rondas.component.html',
  styleUrls: ['./rondas.component.css']
})
export class RondasComponent implements OnInit {

  CodigoRonda:string;
  CodigoJugador1: string;
  NombreJugador1: string;
  NumeroRonda: number = 0;
  MovimientoJugador1:number;

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string,
  protected RondaService: RondaService) {
    this.obtener_localstorage();
    this.NumeroRonda = this.NumeroRonda + 1;
    this.llenar_locarstorage();
  }

  ngOnInit() {
  }

  obtener_localstorage() {
    this.NombreJugador1 = localStorage.getItem("NombreJugador1");
    this.CodigoJugador1 = localStorage.getItem("CodigoJugador1");
  }

  llenar_locarstorage(){
    localStorage.setItem("NumeroRonda", this.NumeroRonda.toString());
  }

  public Add() {
    if (this.NumeroRonda == 1){
      this.CodigoRonda = Math.random().toString();
      localStorage.setItem("CodigoRonda", this.CodigoRonda.toString());
    }

    this.RondaService.Add(this.CodigoRonda, this.CodigoJugador1,
      "", this.MovimientoJugador1,0, this.NumeroRonda);
  }

  public Piedra(){
    this.MovimientoJugador1 = 1;
  }

  public Papel(){
    this.MovimientoJugador1 = 2;
  }

  public Tijera(){
    this.MovimientoJugador1 = 3;
  }

}
