import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { faTrashAlt } from '@fortawesome/free-solid-svg-icons';
import { ConfigurationGroup } from 'src/app/models/configurations/configurationGroup';
import { ConfigurationService } from 'src/app/services/configuration.service';

@Component({
  selector: 'app-configurations',
  templateUrl: './configurations.component.html',
  styleUrls: ['./configurations.component.scss'],
})
export class ConfigurationsComponent implements OnInit {
  displayedColumns: string[] = [
    'id',
    'code',
    'description',
    'relatedSubject',
    'lastUpdatedDate',
    'lastUpdatedUserName',
    'comment',
    'delete',
  ];
  deleteIcon = faTrashAlt;
  dataSource = new MatTableDataSource<ConfigurationGroup>();

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private configurationService: ConfigurationService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.loadConfigGroups();
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  loadConfigGroups() {
    this.configurationService.getConfigurationGroups().subscribe(
      (res) => (this.dataSource.data = res.filter((i) => !i.isDeleted)),
      (err) => console.log(err)
    );
  }

  delete(id: number) {}

  addConfigurationGroup() {}

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  selectGroup(id: number) {
    this.router.navigate([id + '/itemsManagement'], {
      relativeTo: this.route,
    });
    console.log(id);
  }
}
