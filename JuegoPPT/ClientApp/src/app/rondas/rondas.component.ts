import { Component, OnInit } from '@angular/core';
import { Local } from 'protractor/built/driverProviders';

@Component({
  selector: 'app-rondas',
  templateUrl: './rondas.component.html',
  styleUrls: ['./rondas.component.css']
})
export class RondasComponent implements OnInit {

  CodigoJugador1: string;
  NombreJugador1: string;
  CodigoJugador2: string;
  NombreJugador2: string;

  constructor() {
    this.obtener_localstorage();
  }

  ngOnInit() {
  }

  obtener_localstorage() {
    this.NombreJugador1 = localStorage.getItem("NombreJugador1");
  }

  public Add() {

  }

}
