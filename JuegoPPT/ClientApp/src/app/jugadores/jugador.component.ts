import { HttpClient } from "@angular/common/http";
import { Component, Inject, OnInit } from "@angular/core";
import { JugadorService } from "../service/jugador.service";
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";

@Component({
  selector: 'jugador-app',
  templateUrl: "./jugador.component.html"
})

export class JugadorComponent implements OnInit{

  Jugador1 = new FormControl;
  Jugador2 = new FormControl;
  CodigoJugador1: string;
  CodigoJugador2: string;


  myForm: FormGroup;

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string,
    protected JugadorService: JugadorService,public fb: FormBuilder) {
      this.myForm = this.fb.group({
        Jugador1: ['', [Validators.required]],
        Jugador2: ['', [Validators.required]],
      });

  }

  ngOnInit() { }


  public Add() {
    this.CodigoJugador1 = Math.random().toString();
    this.CodigoJugador2 = Math.random().toString();

    localStorage.setItem("CodigoJugador1", this.CodigoJugador1);
    localStorage.setItem("NombreJugador1", this.Jugador1.value);
    localStorage.setItem("CodigoJugador2", this.CodigoJugador2);
    localStorage.setItem("NombreJugador2", this.Jugador2.value);

    this.JugadorService.Add(this.CodigoJugador1, this.Jugador1.value, this.CodigoJugador2, this.Jugador2.value);

  }

  saveData() {
    console.log(this.myForm.value);
  }


}
