import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { JugadorService } from "../service/jugador.service";
import { FormControl } from "@angular/forms";

@Component({
  selector: 'jugador-app',
  templateUrl: "./jugador.component.html"
})

export class JugadorComponent {

  nameControl = new FormControl('');


  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string,
    protected JugadorService: JugadorService) {

  }

  public Add() {
    this.JugadorService.Add(this.nameControl.value);
  }
}
