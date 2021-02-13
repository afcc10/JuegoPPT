import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { JugadorComponent } from './jugadores/jugador.component'
import { RondasComponent } from './rondas/rondas.component';
import { RondaJugador2Component } from './ronda-jugador2/ronda-jugador2.component';

import { JugadorService } from './service/jugador.service';
import { RondaService } from './service/ronda.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    JugadorComponent,
    RondasComponent,
    RondaJugador2Component
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule, ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'Juego', component: JugadorComponent},
      { path: 'Rondas', component: RondasComponent},
      { path: 'RondasJ2', component: RondaJugador2Component}
    ])
  ],
providers: [JugadorService,
            RondaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
