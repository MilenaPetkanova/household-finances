import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CapitalListComponent } from './capital-list.component';

describe('CapitalListComponent', () => {
  let component: CapitalListComponent;
  let fixture: ComponentFixture<CapitalListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CapitalListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CapitalListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
