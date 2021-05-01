import { Component, OnInit } from '@angular/core';
import { ConfigurationGroup } from 'src/app/models/configurations/configurationGroup';
import { ConfigurationService } from 'src/app/services/configuration.service';

@Component({
  selector: 'app-configurations',
  templateUrl: './configurations.component.html',
  styleUrls: ['./configurations.component.scss'],
})
export class ConfigurationsComponent implements OnInit {
  configurationGroups!: ConfigurationGroup[];
  displayedColumns: string[] = [
    'id',
    'code',
    'description',
    'relatedSubject',
    'lastUpdatedDate',
    'lastUpdatedUserName',
    'comment',
  ];

  constructor(private configurationService: ConfigurationService) {}

  ngOnInit(): void {
    this.loadConfigGroups();
  }

  loadConfigGroups() {
    this.configurationService.getConfigurationGroups().subscribe(
      (res) => (this.configurationGroups = res),
      (err) => console.log(err),
      () => console.log(this.configurationGroups)
    );
  }
}
