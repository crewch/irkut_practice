import {
	Box,
	LinearProgress,
	List,
	ListItem,
	ListItemButton,
	ListItemText,
	Typography,
} from '@mui/material'
import { useAppDispatch, useAppSelector } from '../../../../hooks/reduxHooks'
import { changeOpenedStage } from '../../../../store/processStageSlice/processStageSlice'
import { useQuery } from '@tanstack/react-query'
import { stageService } from '../../../../services/stage'
import { useGetUserData } from '../../../../hooks/userDataHook'
import ListImg from '../../ListImg/ListImg'
import styles from './StagesListStyle.module.scss'

const StagesList = () => {
	const openedStage = useAppSelector(state => state.processStage.openedStage)
	const dispatch = useAppDispatch()

	const userData = useGetUserData()

	const {
		data: listStages,
		isLoading,
		isSuccess,
	} = useQuery({
		queryKey: ['stagesAllByUserId'],
		queryFn: () => stageService.getStageAllByUserId(userData.id),
	})

	return (
		<Box className={`${styles.container} h-full justify-between p-0`}>
			{isLoading && <LinearProgress />}
			{isSuccess && listStages && (
				<>
					<List component='nav' className={styles.list}>
						{listStages.map((stage, index) => (
							<ListItem
								disablePadding
								key={index}
								className={
									openedStage === stage.id
										? styles.openedProcessWrap
										: styles.closedProcessWrap
								}
							>
								<ListImg status={stage.status} />
								<ListItemButton
									className={styles.openedProcess}
									onClick={() => dispatch(changeOpenedStage({ id: stage.id }))}
								>
									<ListItemText>
										<Typography
											className={
												openedStage === stage.id
													? styles.openedProcessText
													: styles.closedProcessText
											}
										>
											{stage.title}
										</Typography>
									</ListItemText>
								</ListItemButton>
							</ListItem>
						))}
					</List>
				</>
			)}
		</Box>
	)
}

export default StagesList