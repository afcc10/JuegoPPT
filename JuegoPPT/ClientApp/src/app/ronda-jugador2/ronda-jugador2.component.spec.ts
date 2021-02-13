import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RondaJugador2Component } from './ronda-jugador2.component';

describe('RondaJugador2Component', () => {
  let component: RondaJugador2Component;
  let fixture: ComponentFixture<RondaJugador2Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RondaJugador2Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RondaJugador2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
