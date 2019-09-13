import { Component, OnInit} from '@angular/core';
import { ChartType, ChartDataSets } from 'chart.js';
import { Label, Color } from 'ng2-charts';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import * as jspdf from 'jspdf';
import * as html2canvas from 'html2canvas';

@Component({
  selector: 'app-cbars-events',
  templateUrl: './cbars-events.component.html',
  styleUrls: ['./cbars-events.component.css']
})


export class CBarsEventsComponent implements OnInit {

  private idUser: string = sessionStorage.getItem("idUser");

  public barChartLabels: Label[] = [];
  public barChartLegend = true;
  public barChartType = 'bar';
  public barChartData: ChartDataSets[] = [{ data: [], label: "" }];
  public ChartColors: Color[] = [{ backgroundColor: 'rgba(40, 180, 99, .6)' }]

  public show: boolean;

  public validate: string;

  constructor (private router: Router, private http: HttpClient) {

    this.show = false;

//    this.getBarras();

  }


  public ngOnInit(): void {


  }


  public getBarras():void {


    this.http.get<any>("api/Ciudadanos/ObtenerInformacionBarras2").subscribe(result => {


      console.log(result);

      this.barChartLabels = result.centros;
      this.barChartData = [

        { data: result.eventos, label: 'Eventos' }

      ];


    });



  }



  generarPDF() {

    var data = document.getElementById("bars");
    html2canvas(data).then(canvas => {
      // Few necessary setting options  
      var imgWidth = 280;
      //var pageHeight = 400;
      var imgHeight = canvas.height * imgWidth / canvas.width;
      //var heightLeft = imgHeight;

      const contentDataURL = canvas.toDataURL('image/png')
      let pdf = new jspdf('l', 'mm', 'A4'); // A4 size page of PDF  
      var position = 10;
      pdf.addImage(contentDataURL, 'png', 0, position, imgWidth, imgHeight)
      pdf.save('c-bars.pdf'); // Generated PDF   
    });

  }



  public Maximizar(): void {

    this.router.navigate(["/c-big-visual-bars-events"]);

  }

  public Regresar(): void {

    this.router.navigate(["/c-stats"]);

  }


}
