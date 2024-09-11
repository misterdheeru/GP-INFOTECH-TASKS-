import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentCommunication2Component } from './component-communication-2.component';

describe('ComponentCommunication2Component', () => {
  let component: ComponentCommunication2Component;
  let fixture: ComponentFixture<ComponentCommunication2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ComponentCommunication2Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ComponentCommunication2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
