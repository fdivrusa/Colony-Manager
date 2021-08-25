import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { Subscription } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { ConfigurationItem } from 'src/app/models/configurations';
import { ConfigurationService } from 'src/app/services/configuration.service';
import { faTrashAlt } from '@fortawesome/free-solid-svg-icons';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

@Component({
  selector: 'app-configuration-items',
  templateUrl: './configuration-items.component.html',
  styleUrls: ['./configuration-items.component.scss'],
})
export class ConfigurationItemsComponent implements OnInit {
  private routeSub: Subscription | undefined;
  private configGenericItems: ConfigurationItem[] | undefined;

  displayedColumns: string[] = [
    'id',
    'code',
    'description',
    'createdDate',
    'lastUpdatedDate',
    'lastUpdatedUserName',
    'comment',
    'delete',
  ];
  deleteIcon = faTrashAlt;
  dataSource = new MatTableDataSource<ConfigurationItem | undefined>();

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private route: ActivatedRoute,
    private configurationService: ConfigurationService
  ) {}

  ngOnInit(): void {
    this.routeSub = this.route.params.subscribe((params) => {
      this.loadRelatedItems(params['id']);
    });
  }

  loadRelatedItems(selectedGroupId: number) {
    this.configurationService.getConfigurationItems(selectedGroupId).subscribe(
      (res) => (this.dataSource.data = res.configGenericItems),
      (err) => console.log(err)
    );
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  addConfigGenericItem() {}

  delete(id: number) {}
}
