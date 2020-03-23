import { BoletimService } from "./../core/services/api/boletim.service";
import { AfterViewInit, Component, OnInit } from "@angular/core";
import { BoletimModel } from "../core/services/api/models/boletim.model";
import { BairrosService } from "../core/services/api/bairros.service";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  styleUrls: ["./home.component.css"]
})
export class HomeComponent implements OnInit, AfterViewInit {
  constructor(
    private boletimService: BoletimService,
    private bairrosService: BairrosService
  ) {}

  ultimoBoletim = new BoletimModel();
  bairroAfetados = [];

  ngAfterViewInit(): void {}

  ngOnInit(): void {
    this.boletimService.getTotais().subscribe(res => {
      this.ultimoBoletim = res.Data[0];
    });
    this.bairrosService.getAfetados().subscribe(res => {
      this.bairroAfetados = res.Data;
    });
  }
}
