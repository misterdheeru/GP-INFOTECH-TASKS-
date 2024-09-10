import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DadaBindingComponent } from './dada-binding.component';

describe('DadaBindingComponent', () => {
  let component: DadaBindingComponent;
  let fixture: ComponentFixture<DadaBindingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DadaBindingComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DadaBindingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
